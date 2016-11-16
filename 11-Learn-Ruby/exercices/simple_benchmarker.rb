class SimpleBenchmarker
    def run(description, &block)
        start_time = Time.now
        yield
        end_time = Time.now
        elapsed = end_time -  start_time
        puts "\n"
        puts "#{description} results"
        puts "Elapsed time: #{elapsed} seconds"
    end
end

benchmarker = SimpleBenchmarker.new
benchmarker.run "Sleep a random amount of time" do
    5.times do
        print "."
        sleep(rand(0.1..1.0))
    end
end
