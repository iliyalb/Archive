people = {
    'Alice': {
        'phone': '2341',
        'address': 'Foo drive 23'
        },
    'Beth': {
        'phone': '9102',
        'address': 'Bar street 42'
        },
    'Cecil': {
        'phone': '3158',
        'address': 'Baz avenue 90'
        }
    }
labels = {
    'phone': 'phone number',
    'address': 'street address'
    }
name = input('Name: ')
request = input('Phone number (p) or street address (a)? ')

if request == 'p': key = 'phone'
if request == 'a': key = 'address'

if name in people: print("%s's %s is %s." %(name, labels[key], people[name][key]))

enter=input ()
