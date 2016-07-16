Imports System.Net
Imports ArtNet.Packets
Imports ArtNet.Sockets
Imports System.ComponentModel
Imports System.Runtime.InteropServices

''DMX Override requires LJ version 2.5 build 1 or higher.
Public Class frmMain
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Public Const WM_USER As Int32 = &H400 ''1024
    Public Const WM_COPYDATA As Integer = &H4A ''74
    Public Const _WMCOPY_DMXOverride As Integer = 267
    <StructLayout(LayoutKind.Sequential)>
    Private Structure CopyData
        Public dwData As Integer
        Public cbData As Integer
        Public lpData As IntPtr
    End Structure
    Dim cdStruct As New CopyData

    <StructLayout(LayoutKind.Sequential, Pack:=0)>
    Private Structure DMXData
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16, ArraySubType:=UnmanagedType.U4)>
        Public Reserved() As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2048)>
        Public ChFlags() As Byte ''0:ignore, 1:override
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2048)>
        Public Values() As Byte
    End Structure
    Dim _dmxData As New DMXData
    Dim _cdPtr As IntPtr

    Dim LJWindowHandle As IntPtr

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 5000
        cmdStartStop.Enabled = False

        ''initialize some dummy dmx values
        ReDim _dmxData.Reserved(15)
        '_dmxData.Reserved = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim maxChan As Integer = 2047 '511, 1023, 1535, 2047
        ReDim _dmxData.ChFlags(maxChan)
        ReDim _dmxData.Values(maxChan)
        For u As Integer = 0 To maxChan
            If (14 <= u And u <= 77) Or (93 <= u And u <= 156) Or (172 <= u And u <= 235) Or (251 <= u And u <= 314) Or
                (526 <= u And u <= 589) Or (605 <= u And u <= 668) Or (684 <= u And u <= 747) Or (763 <= u And u <= 826) Or
                (1038 <= u And u <= 1101) Or (1117 <= u And u <= 1180) Or (1196 <= u And u <= 1259) Or (1275 <= u And u <= 1338) Then
                _dmxData.ChFlags(u) = 1
            Else
                _dmxData.ChFlags(u) = 0
            End If
            _dmxData.Values(u) = 0
        Next

        cdStruct.dwData = _WMCOPY_DMXOverride
        cdStruct.cbData = Marshal.SizeOf(_dmxData)
        cdStruct.lpData = Marshal.AllocHGlobal(Marshal.SizeOf(_dmxData))
        Marshal.StructureToPtr(_dmxData, cdStruct.lpData, False)

        _cdPtr = Marshal.AllocHGlobal(Marshal.SizeOf(cdStruct))
        Marshal.StructureToPtr(cdStruct, _cdPtr, False)

        Dim artnet As ArtNetSocket = New ArtNetSocket()
        artnet.EnableBroadcast = True
        'Console.WriteLine(artnet.BroadcastAddress.ToString())
        artnet.Open(IPAddress.Parse("127.0.0.1"), IPAddress.Parse("255.255.255.0"))
        AddHandler artnet.NewPacket, AddressOf ProcessPacket

        DetectLightJockey()
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Marshal.FreeHGlobal(cdStruct.lpData)
        Marshal.FreeHGlobal(_cdPtr)
    End Sub

    Private Sub ProcessPacket(sender As Object, e As NewPacketEventArgs(Of ArtNetPacket))
        If (e.Packet.OpCode = ArtNet.Enums.ArtNetOpCodes.Dmx) Then
            Dim packet As ArtNetDmxPacket = TryCast(e.Packet, ArtNet.Packets.ArtNetDmxPacket)
            If packet.Universe < 4 Then
                For i As Integer = 0 To packet.Length - 1
                    _dmxData.Values((packet.Universe * 512) + i) = packet.DmxData(i)
                Next
            End If

            'If packet.DmxData IsNot _dmxData Then
            '    Console.WriteLine("New Packet")
            '    Dim i As Integer = 0
            '    While i < packet.DmxData.Length
            '        If packet.DmxData(i) <> 0 Then
            '            Console.WriteLine(i + " = " + packet.DmxData(i))
            '        End If
            '        i = i + 1
            '    End While
            '    _dmxData = packet.DmxData
            'End If
        End If
    End Sub

    Public Sub DetectLightJockey()
        ''Find LightJockey Window
        ''Class name "TLJMainForm", window name "LightJockey"
        LJWindowHandle = FindWindow("TLJMainForm", vbNullString)
        If LJWindowHandle <> IntPtr.Zero Then
            pbLightJockey.Image = My.Resources.icons.statusyellow
            Call DetectLJReadyState()
            Exit Sub
        End If
        Timer.Enabled = True
    End Sub

    Public Sub DetectLJReadyState()
        'Find out if LightJockey is ready
        Dim res As Integer = CType(SendMessage(LJWindowHandle, WM_USER + 1502, IntPtr.Zero, IntPtr.Zero), Integer)
        If res = 1 Then
            pbLightJockey.Image = My.Resources.icons.statusgreen
            Timer.Enabled = False
            Timer.Interval = 100
            cmdStartStop.Enabled = True
        Else
            Timer.Enabled = True
        End If
    End Sub

    Public Sub SendDMXValues()
        ''Refresh data before sending?
        Marshal.StructureToPtr(_dmxData, cdStruct.lpData, True)
        Marshal.StructureToPtr(cdStruct, _cdPtr, True)

        Dim res As IntPtr = SendMessage(LJWindowHandle, WM_COPYDATA, Me.Handle, _cdPtr)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Timer.Interval = 5000 Then
            DetectLightJockey()
        Else
            SendDMXValues()
        End If
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStartStop.Click
        If Timer.Enabled Then
            Timer.Enabled = False
            cmdStartStop.Text = "Start"
        Else
            Timer.Enabled = True
            cmdStartStop.Text = "Stop"
        End If
    End Sub
End Class