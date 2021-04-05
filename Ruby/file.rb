File.write("text.txt","I", mode: "a")
file = File.open("text.txt")
text = File.read(file)
puts text