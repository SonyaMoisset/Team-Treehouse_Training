class Player
  include Comparable

  attr_accessor :name, :score

  def initialize(name, score)
    @name, @score = name, score
  end

  def <=> (other_player)
    score <=> other_player.score
  end
end

class Game
  include Enumerable

  attr_accessor :players

  def initialize
    @players = []
  end

  def each(&block)
    players.each(&block)
  end

  def add_player(player)
    players.push(player)
  end

  def score
    score = 0
    players.each do |player|
      score += player.score
    end
    score
  end
end

player1 = Player.new("Jason", 100)
player2 = Player.new("Kenneth", 80)
player3 = Player.new("Nick", 95)
player4 = Player.new("Craig", 20)

game1 = Game.new
game1.add_player(player1)
game1.add_player(player2)

game2 = Game.new
game2.add_player(player3)
game2.add_player(player4)

puts game1.inspect

puts.game1.any?{|player| player.score > 80}

players = game1.find{|player| player.score > 80}
puts "Players with a score > 80", players.inspect
