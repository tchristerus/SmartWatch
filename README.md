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
	- [ ] nextMode()
	- [x] getCurrentMode()
	- [ ] tick()
	- [ ] buttonOnePressed()
	- [ ] buttonTwoPressed()
	- [ ] buttonBothPressed()

#### IMode
 - [x] IMode
	- [x] Mode(Time time)
	- [x] tick()
	- [x] buttonOne()
	- [x] buttonTwo()
	- [x] drawGui(Panel panel)
	- [x] switchCase()

#### Time
 - [ ] Time
	- [ ] incrementHours(Time time)
	- [ ] incrementMinutes()
	- [ ] incrementSeconds()

#### AudioManager
 - [ ] AudioManager
	- [ ] audioManager()
	- [ ] addSongs()
	- [ ] loadSong()
	- [ ] playSong()
	- [ ] pauseSong()
	- [ ] playPauseSong()
	- [ ] nextSong()
	- [ ] previousSong()
	- [ ] getNextSong()
	- [ ] getPreviousSong()
	- [ ] volumeUp()
	- [ ] volumeDown()

#### Song
 - [ ] Song
	- [ ] Song (string path, string artist, string title)
	- [ ] getPath()
	- [ ] getTitle()
	- [ ] getArtist()

#### TimeManager <i>((Not created yet))</i>
 - [ ] TimeManager

#### TimeMode <i>((Not created yet))</i>
 - [ ] TimeMode

#### AudioPlayerMode <i>((Not created yet))</i>
 - [ ] AudioPlayerMode
