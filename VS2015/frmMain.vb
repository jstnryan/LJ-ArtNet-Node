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
            'ChFlags = New Byte() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            For f As Integer = 0 To 2047
                ChFlags(f) = 1
            Next
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

    Private Structure TicksSince
        Private _universe() As Integer

        Default ReadOnly Property Ticks(ByVal universe As Integer) As Integer
            Get
                Return _universe(universe)
            End Get
        End Property

        Public Sub New(Optional ByVal initial As Integer = Integer.MaxValue)
            ReDim _universe(3)
            _universe(0) = initial
            _universe(1) = initial
            _universe(2) = initial
            _universe(3) = initial
        End Sub

        Public Sub AddTick()
            If _universe(0) < Integer.MaxValue Then _universe(0) += 1
            If _universe(1) < Integer.MaxValue Then _universe(1) += 1
            If _universe(2) < Integer.MaxValue Then _universe(2) += 1
            If _universe(3) < Integer.MaxValue Then _universe(3) += 1
        End Sub

        Public Sub Reset(ByVal universe As Integer)
            _universe(universe) = 0
        End Sub
    End Structure
    Private lastSeen As TicksSince = New TicksSince(Integer.MaxValue)

    Protected Overrides Sub OnLoad(e As EventArgs)
        timerInput.Interval = 500
        timerInput.Enabled = False
        timerOutput.Interval = 5000
        timerOutput.Enabled = False
        cmdOutputStartStop.Enabled = False
        ipArtnet.IPAddress = If(My.Settings.IPAddress Is Nothing, IPAddress.Parse("127.0.0.1"), My.Settings.IPAddress)
        ipSubnet.IPAddress = If(My.Settings.Subnet Is Nothing, IPAddress.Parse("127.0.0.1"), My.Settings.Subnet)
        nudUniverse1.Value = My.Settings.Universe1
        nudUniverse2.Value = My.Settings.Universe2
        nudUniverse3.Value = My.Settings.Universe3
        nudUniverse4.Value = My.Settings.Universe4
        nudInterval.Value = My.Settings.Interval
        'If My.Settings.ChFlags Is Nothing Then My.Settings.ChFlags = _dmxData.ChFlags
        If Not My.Settings.ChFlags Is Nothing Then
            _dmxData.ChFlags = My.Settings.ChFlags
        End If

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
        If timerInput.Enabled Then
            timerInput.Enabled = False
            DisconnectArtNet()
            ipArtnet.Enabled = True
            ipSubnet.Enabled = True
            nudUniverse1.Enabled = True
            nudUniverse2.Enabled = True
            nudUniverse3.Enabled = True
            nudUniverse4.Enabled = True
            pbArtnet1.Image = My.Resources.icons.statusred
            pbArtnet2.Image = My.Resources.icons.statusred
            pbArtnet3.Image = My.Resources.icons.statusred
            pbArtnet4.Image = My.Resources.icons.statusred
            cmdInputStartStop.Text = "Input Start"
        End If

        If timerOutput.Enabled Then
            timerOutput.Enabled = False
            nudInterval.Enabled = True
            cmdOutputStartStop.Text = "Output Start"
        End If

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
            Dim destUniv As Byte
            Select Case CInt(packet.Universe)
                Case My.Settings.Universe1
                    destUniv = 0
                Case My.Settings.Universe2
                    destUniv = 1
                Case My.Settings.Universe3
                    destUniv = 2
                Case My.Settings.Universe4
                    destUniv = 3
                Case Else
                    Exit Sub
            End Select
            lastSeen.Reset(destUniv)
            For i As Integer = 0 To packet.Length - 1
                _dmxData.Values((destUniv * 512) + i) = packet.DmxData(i)
            Next
            ''Update frmSettings?
            'If Application.OpenForms().OfType(Of frmSettings).Any = True Then frmSettings.UpdateValues(packet.Universe)

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
        timerOutput.Enabled = True
    End Sub

    Public Sub DetectLJReadyState()
        'Find out if LightJockey is ready
        Dim res As Integer = CType(SendMessage(LJWindowHandle, WM_USER + 1502, IntPtr.Zero, IntPtr.Zero), Integer)
        If res = 1 Then
            pbLightJockey.Image = My.Resources.icons.statusgreen
            timerOutput.Enabled = False
            timerOutput.Interval = My.Settings.Interval
            cmdOutputStartStop.Enabled = True
        Else
            timerOutput.Interval = 5000
            pbLightJockey.Image = My.Resources.icons.statusyellow
            timerOutput.Enabled = True
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
            timerOutput.Enabled = False
            cmdOutputStartStop.Text = "Output Start"
            cmdOutputStartStop.Enabled = False
        End Try
    End Sub

    Private Sub timerOutput_Tick(sender As Object, e As EventArgs) Handles timerOutput.Tick
        If Not cmdOutputStartStop.Enabled Then
            DetectLightJockey()
        Else
            'lastSeen.AddTick()
            SendDMXValues()
        End If
    End Sub

    Private Sub cmdOutputStartStop_Click(sender As Object, e As EventArgs) Handles cmdOutputStartStop.Click
        If timerOutput.Enabled Then
            timerOutput.Enabled = False
            nudInterval.Enabled = True
            cmdOutputStartStop.Text = "Output Start"
        Else
            nudInterval.Enabled = False
            timerOutput.Enabled = True
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
            timerInput.Enabled = True
        Else
            timerInput.Enabled = False
            DisconnectArtNet()
            ipArtnet.Enabled = True
            ipSubnet.Enabled = True
            nudUniverse1.Enabled = True
            nudUniverse2.Enabled = True
            nudUniverse3.Enabled = True
            nudUniverse4.Enabled = True
            pbArtnet1.Image = My.Resources.icons.statusred
            pbArtnet2.Image = My.Resources.icons.statusred
            pbArtnet3.Image = My.Resources.icons.statusred
            pbArtnet4.Image = My.Resources.icons.statusred
            cmdInputStartStop.Text = "Input Start"
        End If
    End Sub

    Private Sub nudInterval_TextChanged(sender As Object, e As EventArgs) Handles nudInterval.TextChanged
        My.Settings.Interval = CInt(nudInterval.Value)
    End Sub

    Private Sub ipArtnet_TextChanged(sender As Object, e As EventArgs) Handles ipArtnet.TextChanged
        My.Settings.IPAddress = ipArtnet.IPAddress
    End Sub

    Private Sub ipSubnet_TextChanged(sender As Object, e As EventArgs) Handles ipSubnet.TextChanged
        My.Settings.Subnet = ipSubnet.IPAddress
    End Sub

    Private Sub nudUniverse1_TextChanged(sender As Object, e As EventArgs) Handles nudUniverse1.TextChanged
        My.Settings.Universe1 = CInt(nudUniverse1.Value)
    End Sub

    Private Sub nudUniverse2_TextChanged(sender As Object, e As EventArgs) Handles nudUniverse2.TextChanged
        My.Settings.Universe2 = CInt(nudUniverse2.Value)
    End Sub

    Private Sub nudUniverse3_TextChanged(sender As Object, e As EventArgs) Handles nudUniverse3.TextChanged
        My.Settings.Universe3 = CInt(nudUniverse3.Value)
    End Sub

    Private Sub nudUniverse4_TextChanged(sender As Object, e As EventArgs) Handles nudUniverse4.TextChanged
        My.Settings.Universe4 = CInt(nudUniverse4.Value)
    End Sub

    Private Sub findNotAlive()
        'Art-Net defines a "Keep-Alive" value of 4 seconds
        'Calculate the number of Timer.Tick events required to consider Universe's data outdated
        Dim tooManyTicks As Integer = CInt(4000 / timerInput.Interval)
        If lastSeen.Ticks(0) < Integer.MaxValue Then
            If tooManyTicks <= lastSeen.Ticks(0) Then
                pbArtnet1.Image = My.Resources.icons.statusyellow
            Else
                pbArtnet1.Image = My.Resources.icons.statusgreen
            End If
        Else
            pbArtnet1.Image = My.Resources.icons.statusred
        End If
        If lastSeen.Ticks(1) < Integer.MaxValue Then
            If tooManyTicks <= lastSeen.Ticks(1) Then
                pbArtnet2.Image = My.Resources.icons.statusyellow
            Else
                pbArtnet2.Image = My.Resources.icons.statusgreen
            End If
        Else
            pbArtnet2.Image = My.Resources.icons.statusred
        End If
        If lastSeen.Ticks(2) < Integer.MaxValue Then
            If tooManyTicks <= lastSeen.Ticks(2) Then
                pbArtnet3.Image = My.Resources.icons.statusyellow
            Else
                pbArtnet3.Image = My.Resources.icons.statusgreen
            End If
        Else
            pbArtnet3.Image = My.Resources.icons.statusred
        End If
        If lastSeen.Ticks(3) < Integer.MaxValue Then
            If tooManyTicks <= lastSeen.Ticks(3) Then
                pbArtnet4.Image = My.Resources.icons.statusyellow
            Else
                pbArtnet4.Image = My.Resources.icons.statusgreen
            End If
        Else
            pbArtnet4.Image = My.Resources.icons.statusred
        End If
    End Sub

    Private Sub timerInput_Tick(sender As Object, e As EventArgs) Handles timerInput.Tick
        lastSeen.AddTick()
        findNotAlive()
    End Sub
End Class