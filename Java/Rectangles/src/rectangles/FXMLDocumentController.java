/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package rectangles;

import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.geometry.Insets;
import javafx.scene.control.Label;
import javafx.scene.layout.FlowPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

/**
 *
 * @author armaa
 */
public class FXMLDocumentController implements Initializable {
    
    @FXML
    private FlowPane FlowPane;
    
    private final int NUMBER_OF_RECT = 40;
    private ArrayList<Rectangle> rectangles = new ArrayList<>();
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        FlowPane.setVgap(5);
        FlowPane.setHgap(5);
        FlowPane.setPadding(new Insets(5, 5, 5, 5));
        
        for (int i = 0; i <= NUMBER_OF_RECT; i++) {
            if (i == NUMBER_OF_RECT/2) {
                Rectangle r = new Rectangle(554, 20);
                r.setFill(Color.ORANGE);
                r.setStroke(Color.BLACK);
                
                FlowPane.getChildren().add(r);
                continue;
            }
            
            Rectangle r = new Rectangle(50, 50);
            r.setId("rect" + i);
            r.setFill(Color.WHITE);
            r.setStroke(Color.BLACK);
            r.setOnMouseClicked(e -> handleButtonAction(r));
            rectangles.add(r);
            FlowPane.getChildren().add(r);
        }
    }    

    private void handleButtonAction(Rectangle r) {
        int index = rectangles.indexOf(r);
        int size = rectangles.size();
        
        Rectangle mirrored = rectangles.get(size - index - 1);
        if (r.getFill().equals(Color.WHITE)) {
            r.setFill(Color.AQUA);
            mirrored.setFill(Color.AQUA);
        }
        else {
            r.setFill(Color.WHITE);
            mirrored.setFill(Color.WHITE);
        }
    }
}
