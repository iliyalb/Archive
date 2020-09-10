import java.time.LocalDate;

import jdk.javadoc.internal.doclets.formats.html.SourceToHTMLConverter;

public class LocalDateNow {
    public static void main(String[] args) {
        LocalDate currentDate = LocalDate.now();
        System.out.println(currentDate.getMonth());
    }
}
