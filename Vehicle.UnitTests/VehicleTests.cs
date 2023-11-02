namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";
            Assert.Equal(expected, andysBike.Summary());

        }
        [Fact]
        public void Drive_AddsMiles()
        {
            Vehicle megansCar = new Vehicle(4, "Green");
            megansCar.Drive();
            var mile = 5;
            Assert.Equal(mile, megansCar.MilesDriven);



        }
        [Fact]
        public void Paint_ChangesColor()
        {
            Vehicle megansCar = new Vehicle(4, "Green");
                megansCar.Paint("Black");
            Assert.Equal("Black",megansCar.Color);




        }


        // Add more tests here!
    }
}