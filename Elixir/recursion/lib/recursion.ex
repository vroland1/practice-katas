defmodule Recursion do
  def reduce([], acc, _func), do: acc
    
  def reduce([head|tail], acc, func) do
    reduce(tail, func.(head, acc), func)
  end

  def count(list) do
    counter = 0

    count_function = fn _number, counter -> counter + 1 end

    reduce(list, counter, count_function)
  end

  def map(enum, func) do
  newList = []
  map_function = fn head, newList -> newList ++ [func.(head)] end
  reduce(enum, newList, map_function)

  end

  #def sum_number_list([], acc), do: acc

  #def sum_number_list([head | tail], acc) do
  #new_acc = head + acc
  #sum_number_list(tail, new_acc)
  #end
end