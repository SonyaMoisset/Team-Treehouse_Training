class Monster
    attr_reader :name, :actions

    def initialize(name)
        @name = name
        @actions = {
            screams: 0,
            scares: 0,
            runs: 0,
            hides: 0
        }
    end

    def print_scoreboard
      puts "------------------------------"
      puts "#{name} scoreboard"
      puts "------------------------------"
      puts "- Screams: #{actions[:screams]}"
      puts "- Scares: #{actions[:scares]}"
      puts "- Runs: #{actions[:runs]}"
      puts "- Hides: #{actions[:hides]}"
      puts "------------------------------"
    end

    def say(&block)
        print "#{name} says..."
        yield
    end

    def scream(&block)
        actions[:screams] += 1
        print "#{name} screams! "
        yield
    end

    def scare(&block)
        actions[:scares] += 1
        print "#{name} scares you! "
        yield
    end

    def run(&block)
        actions[:runs] += 1
        print "#{name} runs! "
        yield
    end

    def hide(&block)
        actions[:hides] += 1
        print "#{name} hides! "
        yield
    end
end

monster = Monster.new("Fluffy")
monster.says { puts "Welcome to my home." }

monster.scream do
    puts "BOO!"
end

monster.scare do
    puts "Go away!"
end

monster.run do
    puts "Going to get you!"
end

monster.hide do
    puts "Running away and hiding!"
end

puts "\n"
monster.print_scoreboard
