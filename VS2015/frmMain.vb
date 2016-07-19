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

        Public Sub New(Optional ByVal chanCount As Integer = 2047) '511, 1023, 1535, 2047
            ReDim Reserved(15)
            ReDim ChFlags(chanCount)
            ReDim Values(chanCount)

            ''initialize some dummy dmx values
            '_dmxData.Reserved = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            'For u As Integer = 0 To chanCount
            '    If (14 <= u And u <= 77) Or (93 <= u And u <= 156) Or (172 <= u And u <= 235) Or (251 <= u And u <= 314) Or
            '        (526 <= u And u <= 589) Or (605 <= u And u <= 668) Or (684 <= u And u <= 747) Or (763 <= u And u <= 826) Or
            '        (1038 <= u And u <= 1101) Or (1117 <= u And u <= 1180) Or (1196 <= u And u <= 1259) Or (1275 <= u And u <= 1338) Then
            '        ChFlags(u) = 1
            '    Else
            '        ChFlags(u) = 0
            '    End If
            '    Values(u) = 0
            'Next
            ChFlags = New Byte() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            'TODO: Remove
            Dim chan As Integer = 0
            For u As Integer = 0 To 7
                For c As Byte = 0 To 255
                    chan = (u * 256) + c
                    Values(chan) = c
                    If c = 255 Then Exit For
                Next c
            Next u
        End Sub
    End Structure
    Private _dmxData As DMXData = New DMXData(2047)
    Private _cdPtr As IntPtr

    Dim LJWindowHandle As IntPtr

    Public Property ChannelFlag(ByVal channel As Integer) As Byte
        Get
            If 0 > channel OrElse channel > 2047 Then Throw New System.Exception("Channel value out of range.")
            Return _dmxData.ChFlags(channel)
        End Get
        Set(value As Byte)
            If value > 1 OrElse value < 0 Then Throw New System.Exception("Flag value out of range.")
            _dmxData.ChFlags(channel) = value
            My.Settings.ChFlags = _dmxData.ChFlags
        End Set
    End Property
    Public ReadOnly Property ChannelValue(ByVal channel As Integer) As Byte
        Get
            If 0 > channel OrElse channel > 2047 Then Throw New System.Exception("Channel value out of range.")
            Return _dmxData.Values(channel)
        End Get
    End Property

    Dim ArtnetConnection As ArtNetSocket

    Protected Overrides Sub OnLoad(e As EventArgs)
        Timer.Interval = 5000
        cmdOutputStartStop.Enabled = False
        ipArtnet.IPAddress = If(My.Settings.IPAddress Is Nothing, IPAddress.Parse("127.0.0.1"), My.Settings.IPAddress)
        ipSubnet.IPAddress = If(My.Settings.Subnet Is Nothing, IPAddress.Parse("127.0.0.1"), My.Settings.Subnet)
        nudUniverse1.Value = My.Settings.Universe1
        nudUniverse2.Value = My.Settings.Universe2
        nudUniverse3.Value = My.Settings.Universe3
        nudUniverse4.Value = My.Settings.Universe4
        nudInterval.Value = My.Settings.Interval
        If My.Settings.ChFlags Is Nothing Then My.Settings.ChFlags = _dmxData.ChFlags

        ''initialize some dummy dmx values
        'ReDim _dmxData.Reserved(15)
        ''_dmxData.Reserved = New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        'Dim maxChan As Integer = 2047 '511, 1023, 1535, 2047
        'ReDim _dmxData.ChFlags(maxChan)
        'ReDim _dmxData.Values(maxChan)
        'For u As Integer = 0 To maxChan
        '    If (14 <= u And u <= 77) Or (93 <= u And u <= 156) Or (172 <= u And u <= 235) Or (251 <= u And u <= 314) Or
        '        (526 <= u And u <= 589) Or (605 <= u And u <= 668) Or (684 <= u And u <= 747) Or (763 <= u And u <= 826) Or
        '        (1038 <= u And u <= 1101) Or (1117 <= u And u <= 1180) Or (1196 <= u And u <= 1259) Or (1275 <= u And u <= 1338) Then
        '        _dmxData.ChFlags(u) = 1
        '    Else
        '        _dmxData.ChFlags(u) = 0
        '    End If
        '    _dmxData.Values(u) = 0
        'Next
        ''TODO: Remove
        'Dim chan As Integer = 0
        'For u As Integer = 0 To 7
        '    For c As Byte = 0 To 255
        '        chan = (u * 256) + c
        '        _dmxData.Values(chan) = c
        '        If c = 255 Then Exit For
        '    Next c
        'Next u

        cdStruct.dwData = _WMCOPY_DMXOverride
        cdStruct.cbData = Marshal.SizeOf(_dmxData)
        cdStruct.lpData = Marshal.AllocHGlobal(Marshal.SizeOf(_dmxData))
        Marshal.StructureToPtr(_dmxData, cdStruct.lpData, False)

        _cdPtr = Marshal.AllocHGlobal(Marshal.SizeOf(cdStruct))
        Marshal.StructureToPtr(cdStruct, _cdPtr, False)

        'ConnectArtNet()
        DetectLightJockey()

        MyBase.OnLoad(e)
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Marshal.FreeHGlobal(cdStruct.lpData)
        Marshal.FreeHGlobal(_cdPtr)
        My.Settings.Save()
    End Sub

    Private Sub ConnectArtNet()
        ArtnetConnection = New ArtNetSocket()
        ArtnetConnection.EnableBroadcast = True
        'Console.WriteLine(ArtnetConnection.BroadcastAddress.ToString())
        'ArtnetConnection.Open(IPAddress.Parse("127.0.0.1"), IPAddress.Parse("255.255.255.0"))
        ArtnetConnection.Open(My.Settings.IPAddress, My.Settings.Subnet)
        AddHandler ArtnetConnection.NewPacket, AddressOf ProcessPacket
    End Sub

    Private Sub DisconnectArtNet()
        ArtnetConnection.Close()
        RemoveHandler ArtnetConnection.NewPacket, AddressOf ProcessPacket
    End Sub

    Private Sub ProcessPacket(sender As Object, e As NewPacketEventArgs(Of ArtNetPacket))
        If (e.Packet.OpCode = ArtNet.Enums.ArtNetOpCodes.Dmx) Then
            Dim packet As ArtNetDmxPacket = TryCast(e.Packet, ArtNet.Packets.ArtNetDmxPacket)
            If packet.Universe < 4 Then
                For i As Integer = 0 To packet.Length - 1
                    _dmxData.Values((packet.Universe * 512) + i) = packet.DmxData(i)
                Next
                'If Application.OpenForms().OfType(Of frmSettings).Any = True Then frmSettings.UpdateValues(packet.Universe)
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
        Else
            pbLightJockey.Image = My.Resources.icons.statusred
        End If
        Timer.Enabled = True
    End Sub

    Public Sub DetectLJReadyState()
        'Find out if LightJockey is ready
        Dim res As Integer = CType(SendMessage(LJWindowHandle, WM_USER + 1502, IntPtr.Zero, IntPtr.Zero), Integer)
        If res = 1 Then
            pbLightJockey.Image = My.Resources.icons.statusgreen
            Timer.Enabled = False
            Timer.Interval = My.Settings.Interval
            cmdOutputStartStop.Enabled = True
        Else
            Timer.Interval = 5000
            pbLightJockey.Image = My.Resources.icons.statusyellow
            Timer.Enabled = True
        End If
    End Sub

    Public Sub SendDMXValues()
        Marshal.StructureToPtr(_dmxData, cdStruct.lpData, True)
        Marshal.StructureToPtr(cdStruct, _cdPtr, True)

        Try
            Dim res As IntPtr = SendMessage(LJWindowHandle, WM_COPYDATA, Me.Handle, _cdPtr)
            If CInt(res) = 1 Then
                pbLightJockey.Image = My.Resources.icons.statusgreen
            Else
                pbLightJockey.Image = My.Resources.icons.statusyellow
            End If
        Catch ex As Exception
            pbLightJockey.Image = My.Resources.icons.statusred
            Timer.Enabled = False
            cmdOutputStartStop.Text = "Output Start"
            cmdOutputStartStop.Enabled = False
        End Try
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Not cmdOutputStartStop.Enabled Then
            DetectLightJockey()
        Else
            SendDMXValues()
        End If
    End Sub

    Private Sub cmdOutputStartStop_Click(sender As Object, e As EventArgs) Handles cmdOutputStartStop.Click
        If Timer.Enabled Then
            Timer.Enabled = False
            nudInterval.Enabled = True
            cmdOutputStartStop.Text = "Output Start"
        Else
            nudInterval.Enabled = False
            Timer.Enabled = True
            cmdOutputStartStop.Text = "Output Stop"
        End If
    End Sub

    Private Sub cmdSettings_Click(sender As Object, e As EventArgs) Handles cmdSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub cmdInputStartStop_Click(sender As Object, e As EventArgs) Handles cmdInputStartStop.Click
        If cmdInputStartStop.Text = "Input Start" Then
            ipArtnet.Enabled = False
            ipSubnet.Enabled = False
            nudUniverse1.Enabled = False
            nudUniverse2.Enabled = False
            nudUniverse3.Enabled = False
            nudUniverse4.Enabled = False
            ConnectArtNet()
            cmdInputStartStop.Text = "Input Stop"
        Else
            DisconnectArtNet()
            ipArtnet.Enabled = True
            ipSubnet.Enabled = True
            nudUniverse1.Enabled = True
            nudUniverse2.Enabled = True
            nudUniverse3.Enabled = True
            nudUniverse4.Enabled = True
            cmdInputStartStop.Text = "Input Start"
        End If
    End Sub

    Private Sub nudInterval_ValueChanged(sender As Object, e As EventArgs) Handles nudInterval.ValueChanged
        My.Settings.Interval = CInt(nudInterval.Value)
    End Sub

    Private Sub ipArtnet_TextChanged(sender As Object, e As EventArgs) Handles ipArtnet.TextChanged
        My.Settings.IPAddress = ipArtnet.IPAddress
    End Sub

    Private Sub ipSubnet_TextChanged(sender As Object, e As EventArgs) Handles ipSubnet.TextChanged
        My.Settings.Subnet = ipSubnet.IPAddress
    End Sub

    Private Sub nudUniverse1_ValueChanged(sender As Object, e As EventArgs) Handles nudUniverse1.ValueChanged
        My.Settings.Universe1 = CInt(nudUniverse1.Value)
    End Sub

    Private Sub nudUniverse2_ValueChanged(sender As Object, e As EventArgs) Handles nudUniverse2.ValueChanged
        My.Settings.Universe2 = CInt(nudUniverse2.Value)
    End Sub

    Private Sub nudUniverse3_ValueChanged(sender As Object, e As EventArgs) Handles nudUniverse3.ValueChanged
        My.Settings.Universe3 = CInt(nudUniverse3.Value)
    End Sub

    Private Sub nudUniverse4_ValueChanged(sender As Object, e As EventArgs) Handles nudUniverse4.ValueChanged
        My.Settings.Universe4 = CInt(nudUniverse4.Value)
    End Sub
End Class