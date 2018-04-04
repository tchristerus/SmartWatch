# SmartWatch
C# Y2_P3_OGO SmartWatch exercise 


### Todo / done

#### Gui
- [x] GUI
	- [x] buttonOneEventHandler()
	- [x] buttonTwoEventHandler()
	- [x] buttonBothEventHandler()

#### SmartWatch
Time obj is initialized but not used (should be updated from the timer event)
 - [ ] SmartWatch
	- [x] SmartWatch(Panel modePanel)
	- [ ] TimerTickEvent(Object myObject, EventArgs myEventArgs)
	- [x] buttonOnePressed()
	- [x] buttonTwoPressed()
	- [x] buttonBothPressed()

#### ModeHandler
 - [ ] ModeHandler
	- [ ] ModeHandler(Panel modePanel) // Not loading in first mode yet
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
 - [ ] AudioManager
	- [ ] audioManager()
	- [ ] addSongs()
	- [x] loadSong()
	- [x] playSong()
	- [x] pauseSong()
	- [ ] playPauseSong()
	- [x] nextSong()
	- [x] previousSong()
	- [ ] getNextSong()
	- [ ] getPreviousSong()
	- [ ] volumeUp()
	- [ ] volumeDown()

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
 - [ ] AudioPlayerMode
