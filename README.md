# ConnectFour

## Question one
The class **_State_** firstly contains **_variables_**, **_array_** for players, **_int_** for rounds played and a **_bool_** with gameover. 
Next is the constructor for **_State_** which contains the initiation of the **_array_** player, which creates two players 
“**_Player_**” and “**_Opponent_**” which starts with 0 points each. Next is the initiation of **_gameRoundsPlayed_** which starts 
off with 0, lastly comes the initiation of **_gameOver_** which is set to false which means that the game is not over. 

Next is the method **_ResetGame_** which does what the name indicates, by putting false on the variable **_gameOver_** it 
shows the game is not over and can continue, next it resets the players points to 0. By doing this we do not 
need to create a new instance of the **_State_** class, we can simply just reset the game. 
Lastly is the method **_EndGame_** which indicates the end of the game by putting the variable **_gameOver_** to true 
followed by adding a round to the variable **_gameRoundsPlayed_**.

## Question two
The class **_State_** has several instances that all help keeping track of the game, which makes the user experience better. 
By keeping data for the players, keep track of when the game is over or resetting the game.

## Question three
The method that is requested is **_ResetGame_** which starts with resetting the board by using the method **_ResetBoard_** from **_GameState.cs_**.
After that it resets the winner message, error message and lastly it cleares out all the pieces.

## Question four
This code creates a **_HTML_** span tag which works for the player to press to generate an game piece. The '<**_span_**>' is an **_HTML_** tag
commonly used to group and style the content in a webpage. The **_title="Click to play a piece"_** is an attribute that will add
a tooltip text that shows if the player hovers over the icon. 

The **_@onclick="() => PlayPiece(col)"_** is an Blazor component which binds an eventhandler to the onclick event inside of the span tag, 
when the player press the span element the given method **_PlayPiece_** will be called with the **_col_** as an argument. The icon is a visual 
representation of the game tile, it is common to use emojis for this purpose especially for games.

## Question five
When there are no format applied to the **_CSS_** class **_@pieces[i]_** the game pieces will not have any kind of styling.
Instead they will just be empty span elements. When it comes to a game this is not ideal. Since the appearance of the game 
pieces are very important in a game, both for clarification of what to do but also the visual appeal. 

## Question six
This method is responsible for handling when a player places a game piece in a column. First it gets the current player, then it
gets the current round that is being played. After this the **_PlayPiece_** method from the **_State_** object is called to place an game piece
in the specified column, then the method returns the row where the game piece lands after being placed. Lastly it will update the array
pieces with a string that represent the last move. 

The string contains information about the players number, column where the game piece 
was placed and the row where it landed.

## Question seven
This method is responsible for resetting all of the games conditions to the start mode. Which means it will reset all the relevant 
variables and data structures that is connected to the game. First it calls the **_ResetBoard_** method that is in the **_State_** object. That method
basically creates a new list with 42 int elements which represents the 42 spots on the game board, all spots is initiated to 0. Next is the 
reset of the winner message and error message. Lastly a new array of 42 strings for pieces, when creating new ones the old ones has to be resetted.

## Question eight
To answer an click event in **_Blazor_** the **_onclick_** attribute is used in the **_HTML_** part to associate with the **_C#_** method during the click. In this 
project the **_onclick_** is used to call the method **_PlayPiece_** when the player clicks the game pieces in the game. The syntax is 
**_@onclick="() => PlayPiece(col)"_** where **_PlayPiece_** is the method and **_col_** is the current column associated with the click.

## Question nine
To place logic which initializes the component you can use the components **_OnInitialized_** method, this is a life cycle method which
runs when the component is first created and initialized. It is a good place to put the logic that needs to be run when the componement is first
rendered. In this game the _**OnInitialized**_ method is used to reset the games board to its starting state when the component is first rendered.

## Question ten
For a component to handle a specific route in **_Blazor_** it has to be rendered within either an _**RouteView**_ or an _**Route**_ component.
Each _**Route**_ component defines a specific path and its associated component. When the user navigates to the specified path the associated component is
rendered. Within the associated component you can use life cycle methods such as _**OnInitializedAsync**_ or _**OnParametersSet**_ to perform logic based
on the specific route or other relevant parameters. 

## Unit testing with XUnit
When doing the unit tests for the method _**CheckForWin**_ I started with the _**CheckForWin_NoWinner_EmptyBoard**_ method. I first **_arrange_** an empty board.
Then call the method _**CheckForWin**_ on the _**_gameState**_ object for the _**act**_ part of the test, since I want to check which state of win is returned
when testing an empty game board. The _**assert**_ part of the test is having three different ways of checking that the outcome is correct. Since it is good 
practice to check in more than one way.

First I check that the _**assert**_ is equal by comparing if the _**CheckForWin**_ is equal to _**WinState.No_Winner**_ which indicates that there is no winner
on an empty board. Then I check if _**assert**_ is false by verifying that _**CheckForWin**_ do not return anything else than the win state of _**No_Winner**_.
Lastly I check if _**assert**_ is true by controlling if all the cells are empty by using the _**All**_ method to test every cell and compare their value with zero.
The tests for _**CheckForWin_NoWinner_EmptyBoard**_ all passes the test. 

Next is the _**CheckForWin_TieGame**_ test method. The _**arrange**_ part here consists of a board filled with gametiles which makes the game a tie. By using a loop
I place pieces from the two players until it is a tie. The _**act**_ part of this test calls the _**CheckForWin**_ method on the _**_gameState**_ object and saves the
result in a _**variable**_. This is done to check which win state is returned when the game is a tie.

The _**assert**_ part of this test has four statements. The first one controls that the returned result from _**CheckForWin**_ is the same as _**WinState.Tie**_, which 
indicates that the game is a tie. The next statement verifies that _**CheckForWin**_ does not return anything else than _**Tie**_. Next statement controls that _**CheckForWin**_
does not return the _**Player1_Wins**_ condition because the game was a tie. Lastly the same control is made for _**Player2_wins**_ for the same reason. The _**CheckForWin_TieGame**_
method does not pass the unit test. 

The message says **_"  Message: Assert.False() Failure Expected: False Actual: True "_**. This indicates that the _**CheckForWin**_ method returns a _**Winstate.Tie**_ even
when it is not a tie. Something could be wrong with the _**CheckForWin**_ method in the _**GameState**_ class. 
