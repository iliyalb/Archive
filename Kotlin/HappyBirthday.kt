fun main() {
    var age = 50;
    val message = "`-._,-'";
    val timesToRepeat = 5;
    
    drawBorder(message, timesToRepeat);
    println("  Happy Birthday, Sag!")
    cake()
    println("  You've turned ${age} and ${age} is the very best age to celebrate!\n")
    drawBorder(message, timesToRepeat);
}

// Draws a cake, probably a chocolate cake!
fun cake() {
    println("     ,,,,,   ")
    println("     |||||   ")
    println("   =========")
    println("  @@@@@@@@@@@")
    println("  {~@~@~@~@~}")
    println("  @@@@@@@@@@@ \n")
}

fun drawBorder(text: String, repeatAmount: Int){
    repeat(repeatAmount){
        print(text)
    }
    println()
}