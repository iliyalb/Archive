class Main {
    public static void main(String[] args) {
        //do not touch this code
        Monopoly monopoly = new Monopoly();
        Chess chess = new Chess();
        Battleships battleships = new Battleships();
        
        monopoly.play();
        chess.play();
        battleships.play();
    }
 }
 
 abstract class Game {
    abstract String getName();
    abstract void play();
 }
 
 class Monopoly extends Game {
 
    //give "Monopoly" name to game
    String getName() {
       return "Buy all property.";
    }
 
    // play method should print "Buy all property."
    void play() {
       System.out.println(getName());
    }
 }
 
 class Chess extends Game {
 
    //give "Chess" name to game
    String getName() {
       return "Kill the enemy king.";
    }
 
    // play method should print "Kill the enemy king"
    void play() {
       System.out.println(getName()); 
    }
 }
 
 class Battleships extends Game {
 
    //give "Battleships" name to game
    String getName() {
        return "Sink all ships.";
    }
 
    // play method should print "Sink all ships"
    void play() {
       System.out.println(getName()); 
    }
 }