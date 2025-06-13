public class Logger {
    private static Logger instance;
    private Logger(){
        System.out.println("LOGGER INITIALIZED");
    }
    public static Logger getInstance(){
        if(instance==null){
            instance = new Logger();
        }
        return instance;
    }
    public void log(String msg){
        System.out.println(msg);
    }
}
