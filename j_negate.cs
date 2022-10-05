class Main {
  public static void main(String[] args) {

    // create int variables
    int a = 65;
    int b = -25;

    // negateExact() with int arguments
    System.out.println(Math.negateExact(a));  // -65
    System.out.println(Math.negateExact(b));  // 25

    // create long variable
    long c = 52336L;
    long d = -445636L;

    // negateExact() with long arguments
    System.out.println(Math.negateExact(c));  // -52336
    System.out.println(Math.negateExact(d));  // 445636
  }
}
