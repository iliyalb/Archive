
# _C++ Examples_


## 📦 Object Oriented

| File name | File type |
| ------ | ------ |
| Test.h | Header |
| Test.cpp | Class |
| Program.cpp | Main |

#### Header:
```cpp
#pragma once
#include <string>
namespace FOO{
  class BAR{
  public:
    std::string Func();
  };
}
```

#### Class:
```cpp
#include "Test.h"
#include <string>
namespace FOO{
  std::string BAR::Func(){
    return std::string("Hello from class!");
  }
}
```

#### Main Program:
```cpp
#include <iostream>
#include <string>
#include "Test.h"
using namespace FOO;
using namespace std;
int main(){
  BAR obj;
  string s = obj.Func();
  cout << s << endl;
  return 0;
}
```
## 🧮 Math

### Oddity evaluation:
```cpp
auto isOdd = [](int candidate) {return candidate % 2 != 0;}; 
bool is2Odd = isOdd(2);
```

## 🎁 Collections

### Vector iteration:
```cpp
for(auto it = begin(oVector); it != end(oVector); it++){
    if(*it == 3) oVector.erase(it);
}
```
