package sample;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.TextField;


public class Controller {

    @FXML private TextField firstName;

    public void handleSaySup(ActionEvent actionEvent) {
        System.out.printf("Sup %s! %n", firstName.getText());
    }
}
