package com.example.myapplication;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class ResultActivity extends AppCompatActivity {

    Button plyAgain;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_result);

        TextView myResult = (TextView) findViewById(R.id.myResult);


        int score = getIntent().getIntExtra("Right_answer_count", 0);


        myResult.setText(score + " /10");



        plyAgain = (Button)findViewById(R.id.plyAgain);
        plyAgain.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                startActivity(new Intent(ResultActivity.this, Main2Activity.class));
            }
        });



    }
}
