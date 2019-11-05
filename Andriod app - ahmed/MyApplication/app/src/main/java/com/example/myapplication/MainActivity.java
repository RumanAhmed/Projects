package com.example.myapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Collections;

public class MainActivity extends AppCompatActivity
{

    //setting the functions
    TextView footy_questions;
    Button btn_t, btn_f;

    Questions tQuestions;
    int questionsLength;

    ArrayList<Item> questionsList;

    int currentQuestion = 0;
    boolean winner = true;


    int rightAnswerCount = 0;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Setting button variables
        footy_questions = (TextView) findViewById(R.id.footy_questions);
        btn_f = (Button) findViewById(R.id.btn_f);
        btn_t = (Button) findViewById(R.id.btn_t);

        tQuestions = new Questions();
        questionsLength = tQuestions.tQuestions.length;

        questionsList = new ArrayList<>();

// incrementing a new question and answer
        for (int i = 0; i < questionsLength; i++){
            questionsList.add(new Item(tQuestions.getQuestion(i), tQuestions.getAnswer(i)));
// Shuffles the questions
            Collections.shuffle(questionsList);

            setQuestion(currentQuestion);


        }
//If the button is true, it will go to next question else it will end
        btn_f.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View view){
                if(!checkQuestion(currentQuestion)){
                    currentQuestion++;
                    if(currentQuestion < questionsLength){
                        setQuestion(currentQuestion);
                        rightAnswerCount++;
                    } else {

                        winner = true;
                        endGame();
                    }

                } else {
                    winner = false;
                    endGame();
                }


            }

        });

        btn_t.setOnClickListener (new View.OnClickListener() {
            @Override
            public void onClick(View view){
                if(checkQuestion(currentQuestion)){
                    currentQuestion++;
                if(currentQuestion < questionsLength){
                        setQuestion(currentQuestion);
                        rightAnswerCount++;
                    } else {

                        winner = true;
                        endGame();
                    }

                } else {
                    winner = false;

                    endGame();
                }


            }

        });
    }

    public void checkAnswer(View view) {

        Button btn_f = (Button) findViewById(view.getId());


    }

    private void setQuestion(int number){
        footy_questions.setText(questionsList.get(number).getQuestion());

    }

    private boolean checkQuestion(int number){
        String answer = questionsList.get(number).getAnswer();
        return answer.equals("True");
    }

    // this is how the game will finish if the correct answers have been clicked
    private void endGame()
    {
        if(winner){
            // Displays short message
            Toast.makeText(this, "Finished, You win!", Toast.LENGTH_SHORT).show();
            finish();
            Intent intent = new Intent(getApplicationContext(), ResultActivity.class);
            intent.putExtra("Right_answer_count", rightAnswerCount);
            startActivity(intent);

        }
        else
            {
            Toast.makeText(this, "Finished, Loser!", Toast.LENGTH_SHORT).show();
            finish();
            Intent intent = new Intent(getApplicationContext(), ResultActivity.class);
            intent.putExtra("Right_answer_count", rightAnswerCount);
            startActivity(intent);


            }
    }

}

