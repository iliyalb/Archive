package com.mehrdadnaderi.introductiontoedittext;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;


public class MainActivity extends ActionBarActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_main);
    }

    public void showFullname(View v)
    {
        EditText etFullname = (EditText)findViewById(R.id.fullnameTextBox);
        String strFullname = etFullname.getText().toString();
        Toast.makeText(this, "Welcome " + strFullname, Toast.LENGTH_LONG).show();
    }

    public void increaseClickListener(View v)
    {
        EditText etNumber = (EditText) findViewById(R.id.etCounter);
        int number = Integer.parseInt(etNumber.getText().toString());
        number++;
        etNumber.setText("" + number);
    }

    public void decreaseClickListener(View v)
    {
        EditText etNumber = (EditText) findViewById(R.id.etCounter);
        int number = Integer.parseInt(etNumber.getText().toString());
        number--;
        etNumber.setText("" + number);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
