fun main() {
    val firstDice = Dice(100)
    val firstCoin = Coin()
    println("${firstDice.sides} sided dice rolled: ${firstDice.roll()}")
    println("Coin flipped: ${firstCoin.flip()}")
}

class Coin() {
    fun flip(): String {
            val result: String
            val temp = (0..1).random()
            if (temp == 0) {
                result = "Heads"
            } else {
                result = "Tails"
            }
            return result
        }
}

class Dice(val sides: Int) {
    fun roll(): Int {
            return (1..sides).random()
        }
}