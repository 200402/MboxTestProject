namespace TestProject1
{
    public class Tests
    {
        [TestCase("0", "0")]
        [TestCase("1", "3,141592653589793")]
        [TestCase("2", "12,566370614359172")]
        public void getInfo_Circle_ReturnCorrectInfo(string shape, string square)
        {
            Shapes.Circle circle = new(shape);
            var answer = new Dictionary<string, string>()
            {
                {"�������", square}
            };
            Assert.That(circle.getInfo, Is.EqualTo(answer));
        }

        [TestCase("3 4 5", "6", "�������������")]
        [TestCase("4 5 6", "9,921567416492215", "�� �������������")]
        [TestCase("5 6 7", "14,696938456699069", "�� �������������")]
        public void getInfo_Triangle_ReturnCorrectInfo(string shape, string square, string �lassification)
        {
            Shapes.Triangle triangle = new(shape);
            var answer = new Dictionary<string, string>()
            {
                {"�������", square},
                {"�������������", �lassification}
            };
            Assert.That(triangle.getInfo()["�������"], Is.EqualTo(square));
            Assert.That(triangle.getInfo()["�������������"], Is.EqualTo(�lassification));// � ������ ��� ����� ��������� �� 2 �����
        }
    }
}