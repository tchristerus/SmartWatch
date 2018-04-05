# SmartWatch
C# Y2_P3_OGO SmartWatch exercise 

## Howto
To start the program go to the debug folder and double click SmartWatch\SmartWatch\bin\Debug\SmartWatch.exe.
To switch mode press the "Both".
Press button "2" to switch activity in current mode.
Press button "1" to start activity.

### Todo / done

#### Gui
- [x] GUI
	- [x] buttonOneEventHandler()
	- [x] buttonTwoEventHandler()
	- [x] buttonBothEventHandler()

#### SmartWatch
Time obj is initialized but not used (should be updated from the timer event)
 - [x] SmartWatch
	- [x] SmartWatch(Panel modePanel)
	- [x] TimerTickEvent(Object myObject, EventArgs myEventArgs)
	- [x] buttonOnePressed()
	- [x] buttonTwoPressed()
	- [x] buttonBothPressed()

#### ModeHandler
 - [x] ModeHandler
	- [x] ModeHandler(Panel modePanel)
	- [x] nextMode()
	- [x] getCurrentMode()
	- [x] tick()
	- [x] buttonOnePressed()
	- [x] buttonTwoPressed()
	- [x] buttonBothPressed()

#### IMode
 - [x] IMode
	- [x] Mode(Time time)
	- [x] tick()
	- [x] buttonOne()
	- [x] buttonTwo()
	- [x] drawGui(Panel panel)
	- [x] switchCase()

#### Time
 - [x] Time
	- [x] incrementHours(Time time)
	- [x] incrementMinutes()
	- [x] incrementSeconds()

#### AudioManager
 - [x] AudioManager
	- [x] audioManager()
	- [x] addSongs()
	- [x] loadSong()
	- [x] playSong()
	- [x] pauseSong()
	- [x] playPauseSong()
	- [x] nextSong()
	- [x] previousSong()
	- [ ] getNextSong()
	- [ ] getPreviousSong()
	- [x] volumeUp()
	- [x] volumeDown()

#### Song
 - [x] Song
	- [x] Song (string path, string artist, string title)
	- [x] getPath()
	- [x] getTitle()
	- [x] getArtist()

#### TimeManager
 - [x] TimeManager

#### TimeMode
 - [x] TimeMode

#### AudioPlayerMode <i>((Not created yet))</i>
 - [x] AudioPlayerMode
