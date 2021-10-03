extends Sprite

var max_health : = 100
var health : = max_health

func take_damage(amount:int) -> void
    health -= amount
    health = max(0, health)

func health(amount:int) -> void
    health += amount
    health = min(health, max_health)