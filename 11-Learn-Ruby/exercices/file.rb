File.open("example.text", "w") do |file|
  print "Enter your name: "
  name = gets.chomp
  file.puts "Name: #{name}"
  
  print "Enter your email: "
  email = gets.chomp
  file.puts "Email: #{email}"
end
