namespace lab_11
{
    class Conveyor
    {
        public void removeSizes(Product product) => product.SizesRemoved = true;
        public void cutOff(Product product) => product.CutOff = true;
        public void toSharpen(Product product) => product.Exiled = true;
        public void cutThread(Product product) => product.CutThread = true;
        public void toDrill(Product product) => product.Drilled = true;
        public void toPaint(Product product) => product.Painted = true;
        public void toTest(Product product) => product.Tested = true;
        public void toPackUp(Product product) => product.Packed = true;
    }
}