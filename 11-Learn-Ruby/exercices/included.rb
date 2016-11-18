module Fetcher
  def self.included(klass)
    attr_accessor :fetch_count

    puts "#{klass} has been included"
  end

  def fetch(item)
    @fetch_count ||= 0
    @fetch_count += 1
    puts "[#{@name}, Fetch count: #{fetch_count}] I'll bring that #{item} right back!"
  end
end

class Dog
  include Fetcher

  def initialize(name)
    @name = name
  end
end

dog = Dog.new("Fido")
dog.fetch("ball")
dog.fetch("toy")

dog2 = Dog.new("Spot")
dog2.fetch("ball")
dog2.fetch("toy")
