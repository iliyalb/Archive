fun main() {
    var sag = "Sag\t"
    val sagi = "Constant Sag"
    var sagj: String = "Explicit Sag\n"
    var space: Char = ' '
    var nullBool: Boolean? = null // var safeCast: String? = x as? String

    println(sag + sagi + space + sagj + nullBool)

    // -128 to 127s
    val leByte: Byte = 8
    // -32768 to 32767
    val leShort: Short = 16
    // -3.4028235x10^38 to 3.4028235x10^38
    val leFloat: Float = 32.0f
    // -2147483648 to 2147483647
    val leInt: Int = 32
    // -1.7976931348623157x10^308 to 1.7976931348623157x10^308
    val leDouble: Double = 64.0
    // -9223372036854775807 to 9223372036854775807
    val leLong: Long = 64L

    var leArray = Array(4) { k -> (k + 1) } // var leArray: IntArray = intArrayOf(0, 1, 2, 3)
    var leArraySum = 0
    leArray.forEach { leArraySum =+ it }

    print(leByte + leShort + leFloat + leInt + leDouble + leLong + leArraySum).toString()
}