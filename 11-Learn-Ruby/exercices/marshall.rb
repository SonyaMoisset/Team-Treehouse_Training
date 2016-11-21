class Player
  attr_accessor :name, :progress

  def initialize(name)
    @name = name
  end
end

player = Player.new("Jason")
player.progress = 60

player_out = Marshal.dump(player)

puts player_out.inspect

player_in = Marshal.load(player_out)

puts player_in.inspect
