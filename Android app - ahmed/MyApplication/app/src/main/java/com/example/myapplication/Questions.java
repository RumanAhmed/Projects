package com.example.myapplication;

public class Questions {
// set questions
    public String tQuestions [] = {
            "Ronaldo is the best player in the world",
            "Messi is the best",
            "Man united is the best",
            "Man united has won BPL 21 time",
            "Liverpool came second in the league in 2018",
            "Neymar is the most expensive player",
            "Mbappe is only 19",
            "Ronaldo has played for 5 clubs",
            "Messi has won a trophy with argentina",
            "Madrid are better without ronaldo",
            "Man united have won the Europa league"


    };
// set answers
    public String tAnswers [] = {
            "True",
            "False",
            "True",
            "False",
            "False",
            "True",
            "True",
            "False",
            "False",
            "False",
            "True"

    };

    public String getQuestion(int number){
        return tQuestions[number];

    }
    public String getAnswer(int number){
        return tAnswers[number];

    }


}
