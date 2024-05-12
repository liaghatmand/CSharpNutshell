using Generics;

int intValue = 0;
var person = new Person();

var instance_1 = new DisplayUtil<int>();
instance_1.DisplayValue(intValue);

var instance_2 = new DisplayUtil<string>();
instance_2.DisplayValue("Zahra");

var instance_3 = new DisplayUtil<Enum>();
instance_3.DisplayValue(Gender.female);

