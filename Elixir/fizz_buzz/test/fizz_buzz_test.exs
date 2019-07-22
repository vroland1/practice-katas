defmodule FizzBuzzTest do
  use ExUnit.Case

  test "returns fizzbuzz when divisible by 3 and 5" do
  assert FizzBuzz.play(15) == "fizzbuzz"
  end

  test "returns buzz for divisible by 5" do
    assert FizzBuzz.play(10) == "buzz"
  end

  test "returns buzz for 5" do
    assert FizzBuzz.play(5) == "buzz"
  end

  test "returns the given number" do
    assert 1 == FizzBuzz.play(1)
  end

  test "returns the given number again" do
    assert 2 == FizzBuzz.play(2)
  end

  test "returns the given number yet again" do
    assert 17 == FizzBuzz.play(17)
  end

  test "returns fizz for 3s" do
    assert FizzBuzz.play(3) == "fizz"
  end

  test "returns fizz for numbers evenly divisible by 3" do
    assert FizzBuzz.play(9) == "fizz"
  end
end
