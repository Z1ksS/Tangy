namespace Tangy_Models
{
    public class TestProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
		public List<TestProductProp> ProductProperties { get; set; }
	}
}
