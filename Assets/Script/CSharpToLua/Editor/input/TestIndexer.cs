namespace Script.CSharpToLua.Editor.input {
    public class TestIndexer {
        private int[] array = new int[10];
        public int this[int index] {
            get {
                return array[index];
            }
            set {
                array[index] = value;
            }
        }
    }
}