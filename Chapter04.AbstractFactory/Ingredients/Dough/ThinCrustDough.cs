namespace Chapter04.AbstractFactory.Ingredients.Dough
{
    public class ThinCrustDough : Dough
    {
        public override string ToString()
        {
            return nameof(ThickCrustDough);
        }
    }
}