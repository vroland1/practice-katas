defmodule FizzBuzz do
  @moduledoc """
  Documentation for FizzBuzz.
  """
  def play(input) when rem(input, 15) == 0 do
    "fizzbuzz"
  end

  def play(input) when rem(input, 5) == 0 do
    "buzz"
  end

  def play(input) when rem(input, 3) == 0 do
    "fizz"
  end

  def play(input), do: input
  end


