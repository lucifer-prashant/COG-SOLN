public class main {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();
        logger1.log("FIRST MSG");
        logger2.log("SECOND MSG");
        System.out.println("ARE LOGGER 1 AND 2 THE SAME? "+(logger1==logger2));
    }
}
