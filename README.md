Overview
---
LJ-ArtNet-Node is a very simple Windows (WinForms) application for receiving DMX over [Art-Net](http://art-net.org.uk/), and importing it into [Martin LightJockey](http://www.martin.com/en-us/product-details/lightjockey-2) PC-based lighting controller using LJ's DMX-Override feature, written in VB.NET.

![LJ-ArtNet-Node ScreenShot](screenshot.png?raw=true)

Download
---
See [Releases](https://github.com/jstnryan/LJ-ArtNet-Node/releases) for pre-compiled binaries.

Features
---
  * Receives up to four (selectable) universes of Art-Net
  * Sends up to four universes of DMX to LightJockey
  * Selectable Art-Net binding address, subnet
  * Selectable, individual channel override
  * Variable DMX to LJ refresh rate (1-1000ms)
  * Whole universe mapping ("Art-Net universe 7 -> LJ universe 3")

Not-Yet Features
---
  * Live view of DMX values in override window
  * Export of settings to file
  * Individual channel mapping (maybe)
  * Conditional channel override (above threshold, non-zero value, etc.)

Requirements
---
  * .NET Framework 4.6.1 (Windows 7 SP1 or later)
  * Visual Studio 2015
  * Uses Michael Chapman's [IPAddressControlLib](https://github.com/m66n/ipaddresscontrollib)
  * Uses Bruno Angeles' [ArtNet.Net](https://github.com/funkmeisterb/ArtNet.Net) library

License (MIT License)
---
Copyright (c) 2016 Justin Ryan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.