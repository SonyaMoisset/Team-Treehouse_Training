def block_method
    puts "This is the first line in block_method."
    yield
    yield
    puts "This statement is after the yield keyword."
end

block_method do
    puts "This statement is called from the block."
end
