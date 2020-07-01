void main() {
  User first = User('first', 'ui421g427');
  first.login();

  User second = User('second', 'v09wgwe9');
  second.login();

  User guest = User.guest();
  guest.login();

  Admin mod = Admin('mod', '0gw89f131!');
  mod.announce();
}

class User {
  String username;
  String password;

  // Default constructor
  /*User(String username, String password) {
    this.username = username;
    this.password = password;
  }*/

  // Shortcut
  User(this.username, this.password);

  // Named constructor
  User.guest() {
    username = 'guest';
    password = ' ';
  }

  void login() {
    print('$username logged in');
  }
}

class Admin extends User {
  Admin(String username, String password) : super(username, password);

  void announce() {
    print('@everyone');
  }
}
