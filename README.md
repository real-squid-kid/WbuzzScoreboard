# WbuzzScoreboard
A simple scoreboard for Wireless Buzz Controllers for PS3

# Binaries are now in /bin/Debug folder

## How to use - READ ME FIRST THEN ASK QUESTIONS
* Connect your USB dongle to your PC.
* You'll need a tool to initialize Buzz controllers for them to be able to be recognized by the system. It's called [SimpleHIDWrite](http://janaxelson.com/hidpage.htm). Launch it and select Wbuzz.
* Below you'll see six fields. Put 00 in each of them so it would look like 00 00 00 00 00 00 00 and press Write.
* After that your Buzz controllers should blink blue light when you push a button on them.
* Launch the app from /bin/debug folder. All files must be present for it to work.
* If you have separate joysticks connected to your system, input the ID of Buzz controllers into the field next to the Initialize button (their name could be something like Microsoft PC-Joystick driver) and push it.
* Now use the Show Scoreboard button to show scoreboard, Reset button to enable buzzing-in (red - can buzz-in, grey - can't) and add/subtract points. <br />

Distrubuted under GNU GPL v3. Please distribute, brand and change to suit your needs, but do not sell.
Using AForge library under LGPL v3 license. More: http://www.aforgenet.com
