void main() {
  User first = User('first', 'ui421g427');
  User second = User('second', 'v09wgwe9');

  first.login();
  second.login();

  Admin mod = Admin('mod', '0gw89f131!');

  mod.announce();
}

class User {
  String username;
  String password;

  User(String username, String password) {
    this.username = username;
    this.password = password;
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
