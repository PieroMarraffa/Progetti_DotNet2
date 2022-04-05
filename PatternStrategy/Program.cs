using PatternStrategy.mezzi;
using PatternStrategy.algoritmi;

Car bmw = new Car("Bmw X1");
Jet AirForceOne = new Jet("Air Force One");

bmw.Go();
AirForceOne.Go();


Car BatMobile = new Car("Bat Mobile");
BatMobile.Go();

BatMobile.setAlgorithm(new GoByFlying());
BatMobile.Go();