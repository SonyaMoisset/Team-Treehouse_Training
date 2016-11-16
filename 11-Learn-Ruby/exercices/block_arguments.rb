def get_name
  print "Enter your name: "
  name = gets.chomp
  yield name
  name
end

my_name = get_name do |your_name|
  puts "That's a cool name, #{your_name}
end

puts "my_name: #{my_name}"
