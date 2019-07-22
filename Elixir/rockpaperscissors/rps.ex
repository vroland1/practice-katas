defmodule RockPaperScissors do
  def rps(p1, p2) do
      match = {p1, p2}
    
      cond do
      p1 == p2 -> "Draw!"
      
      match == {"rock", "scissors"} or match == {"scissors", "paper"} 
      or match == {"paper", "rock"} -> "Player 1 won!"
      
      true -> "Player 2 won!"
      end
  end
end

"""
Rock Paper Scissors
Let's play! You have to return which player won! In case of a draw return Draw!.

Examples:

rps('scissors','paper') // Player 1 won!
rps('scissors','rock') // Player 2 won!
rps('paper','paper') // Draw!
"""