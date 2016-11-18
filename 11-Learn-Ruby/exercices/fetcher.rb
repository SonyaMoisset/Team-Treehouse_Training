module Fetcher
  def fetch(item)
    puts "I'll bring that #{item} right back!"
  end
end

class Dog
  include Fetcher

  def initialize(name)
    @name = name
  end
end

class Cat
  include Fetcher

  def initialize(name)
    @name = name
  end
end

dog = Dog.new("Fido")
dog.fetch("ball")

cat = Cat.new("Garfield")
cat.fetch("laser pointer")
