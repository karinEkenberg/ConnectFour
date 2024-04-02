# ConnectFour

## Question one
The class _State_ firstly contains _variables_, _array_ for players, _int_ for rounds played and a _bool_ with gameover. 
Next is the constructor for _State_ which contains the initiation of the _array_ player, which creates two players 
“_Player_” and “_Opponent_” which starts with 0 points each. Next is the initiation of _gameRoundsPlayed_ which starts 
off with 0, lastly comes the initiation of _gameOver_ which is set to false which means that the game is not over. 

Next is the method _ResetGame_ which does what the name indicates, by putting false on the variable _gameOver_ it 
shows the game is not over and can continue, next it resets the players points to 0. By doing this we do not 
need to create a new instance of the _State_ class, we can simply just reset the game. 
Lastly is the method _EndGame_ which indicates the end of the game by putting the variable _gameOver_ to true 
followed by adding a round to the variable _gameRoundsPlayed_.

## Question two
The class _State_ has several instances that all help keeping track of the game, which makes the user experience better. 
By keeping data for the players, keep track of when the game is over or resetting the game.

## Question three
The method that is requested is _ResetGame_ which starts with resetting the board by using the method _ResetBoard_ from _GameState.cs_.
After that it resets the winner message, error message and lastly it cleares out all the pieces.

## Question four
This code creates a _HTML_ span tag which works for the player to press to generate an game piece. The '<_span_>' is an _HTML_ tag
commonly used to group and style the content in a webpage. The _title="Click to play a piece"_ is an attribute that will add
a tooltip text that shows if the player hovers over the icon. 

The _@onclick="() => PlayPiece(col)"_ is an Blazor component which binds an eventhandler to the onclick event inside of the span tag, 
when the player press the span element the given method _PlayPiece_ will be called with the _col_ as an argument. The icon is a visual 
representation of the game tile, it is common to use emojis for this purpose especially for games.

## Question five
When there are no format applied to the _CSS_ class _@pieces[i]_ the game pieces will not have any kind of styling.
Instead they will just be empty span elements. When it comes to a game this is not ideal. Since the appearance of the game 
pieces are very important in a game, both for clarification of what to do but also the visual appeal. 

## Question six
This method is responsible for handling when a player places a game piece in a column. First it gets the current player, then it
gets the current round that is being played. After this the _PlayPiece_ method from the _State_ object is called to place an game piece
in the specified column, then the method returns the row where the game piece lands after being placed. Lastly it will update the array
pieces with a string that represent the last move. 

The string contains information about the players number, column where the game piece 
was placed and the row where it landed.

## Question seven
This method is responsible for resetting all of the games conditions to the start mode. Which means it will reset all the relevant 
variables and data structures that is connected to the game. First it calls the _ResetBoard_ method that is in the _State_ object. That method
basically creates a new list with 42 int elements which represents the 42 spots on the game board, all spots is initiated to 0. Next is the 
reset of the winner message and error message. Lastly a new array of 42 strings for pieces, when creating new ones the old ones has to be resetted.

## Question eight
To answer an click event in _Blazor_ the _onclick_ attribute is used in the _HTML_ part to assosiate with the _C#_ method during the click. In this 
project the _onclick_ is used to call the method _PlayPiece_ when the playcer clicks the game pieces in the game. The syntax is 
_@onclick="() => PlayPiece(col)"_ where _PlayPiece_ is the method and _col_ is the current column associated with the click.

## Question nine


## Question ten
