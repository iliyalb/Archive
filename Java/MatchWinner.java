import java.util.*; 

public class Match {

    HashMap<String, Integer> players;

    Match() {
        players = new HashMap<String, Integer>();
    }

    public void addPlayer(String name, int p) {
        players.put(name, p);
    }

    public void getWinner(){
        int max = Collections.max(players.values());
        for(Map.Entry<String, Integer> entry : players.entrySet()) {
            if(entry.getValue()==max){
                System.out.println(entry.getKey().toString());
            }
        }

        
    }
}

public class Program {
    public static void main(String[ ] args) {

        Match game = new Match();

        Scanner sc = new Scanner(System.in);

        for(int i=0;i<3;i++) {
            String input = sc.nextLine();
            String[] values = input.split(" ");
            String name = values[0];
            int points = Integer.parseInt(values[1]);
            game.addPlayer(name, points);
        }
        
        game.getWinner();
    }
}