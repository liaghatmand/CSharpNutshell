using GenericsConstraints;

int? intValue = 0;
var person = new Person();
int[] array = [];

var instance_1 = new DisplayUtil();
instance_1.DisplayValue(intValue);

var instance_2 = new DisplayUtil();
instance_2.DisplayValue("Zahra");

var instance_3 = new DisplayUtil();
instance_3.DisplayValue(Gender.female);

var instance_4 = new DisplayUtil();
instance_3.DisplayValue(person);

var  instance_5 = new DisplayUtil();
instance_5.DisplayValue(array);