package com.sismorcego.ufpa.sismorcego;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;

public class Home extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
    }

    public void GotoRegH(View v){
        startActivity(new Intent(Home.this, RegistroH.class));
    }
}
