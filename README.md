# ConnectFour

## Question one
The class State firstly contains variables, array for players, int for rounds played and a bool with gameover. 
 
Next is the constructor for State which contains the initiation of the array player, which creates two players 
“Player” and “Opponent” which starts with 0 points each. Next is the initiation of gameRoundsPlayed which starts 
off with 0, lastly comes the initiation of gameOver which is set to false which means that the game is not over. 

Next is the method ResetGame which does what the name indicates, by putting false on the variable gameOver it 
shows the game is not over and can continue, next it resets the players points to 0. By doing this we do not 
need to create a new instance of the State class, we can simply just reset the game. 

Lastly is the method EndGame which indicates the end of the game by putting the variable gameOver to true 
followed by adding a round to the variable gameRoundsPlayed.

## Question two
The class State has several instances that all help keeping track of the game, which makes the user experience better. 
By keeping data for the players, keep track of when the game is over or resetting the game.

## Question three
The method that is requested is ResetGame() which starts with resetting the board by using the method ResetBoard() from GameState.cs.
After that it resets the winner message, error message and lastly it cleares out all the pieces.

## Question four
This code creates a html span tag which works for the player to press to generate an game piece. The '<span>' is an HTML tag
commonly used to group and style the content in a webpage. The 'title="Click to play a piece"' is an attribute that will add
a tooltip text that shows if the player hovers over the icon. The '@onclick="() => PlayPiece(col)"' is an Blazor component 
which binds an eventhandeler to the onclick event inside of the span tag, when the player press the span element the given method
PlayPiece will be called with the 'col' as an argument. The icon is a visual representation of the game tile, it is common to use
emojis for this purpose especially for games.

## Question five


## Question six

## Question seven

## Question eight

## Question nine
