/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package circles;

import java.net.URL;
import java.util.Random;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.layout.FlowPane;
import javafx.scene.paint.Color;
import javafx.scene.paint.Paint;
import javafx.scene.shape.Circle;

/**
 *
 * @author armaa
 */
public class FXMLDocumentController implements Initializable {

    @FXML
    private FlowPane AnchorPane;
    
    private Random _rnd = new Random(566555555);
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        for (int i = 1; i < 11; i++) {
            Circle c = new Circle(i * 5);
            c.setStroke(Color.BLACK);
            c.setFill(Color.WHITE);
            c.setOnMouseClicked(e -> ChangeCircleColor(c));
            AnchorPane.getChildren().add(c);
        }
    }    

    private void ChangeCircleColor(Circle c) {
        Paint p = new Color(_rnd.nextDouble(), _rnd.nextDouble(), _rnd.nextDouble(), 1);
        c.setFill(p);
    }
}
