package com.mehrdadnaderi.introductiontointent;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageView;
import android.widget.Toast;

public class Startup extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.startup);

        ImageView imageView = (ImageView) findViewById(R.id.supexImageView);
        imageView.setImageDrawable(getResources().getDrawable(R.drawable.supexlogo));
        /*
         * imageView.setOnClickListener(new View.OnClickListener() {
         * 
         * @Override public void onClick(View v) { Intent intent = new
         * Intent(Startup.this, Activity2.class); startActivity(intent); } });
         */
        Thread timer = new Thread() {
            @Override
            public void run() {
                try {
                    sleep(5000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                } finally {
                    Intent intent = new Intent(Startup.this, Activity2.class);
                    startActivity(intent);
                }
            }
        };
        timer.start();
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

        // noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}

/*
 * ACTIVITY II package com.mehrdadnaderi.introductiontointent;
 * 
 * import android.app.Activity; import android.os.Bundle; import
 * android.support.v7.app.ActionBarActivity; import android.view.Menu; import
 * android.view.MenuItem; import android.view.View; import
 * android.widget.EditText; import android.widget.Toast;
 * 
 * 
 * public class Activity2 extends Activity {
 * 
 * @Override protected void onCreate(Bundle savedInstanceState) {
 * super.onCreate(savedInstanceState); setContentView(R.layout.layout2); }
 * 
 * public void showFullnameClickListener(View v) { EditText etFirstName =
 * (EditText)findViewById(R.id.etFirstName); EditText etLastName =
 * (EditText)findViewById(R.id.etLastName); String strFullname =
 * etFirstName.getText().toString() + " " + etLastName.getText().toString();
 * Toast.makeText(this, strFullname, Toast.LENGTH_LONG).show(); }
 * 
 * @Override public boolean onCreateOptionsMenu(Menu menu) { // Inflate the
 * menu; this adds items to the action bar if it is present.
 * getMenuInflater().inflate(R.menu.menu_main, menu); return true; }
 * 
 * @Override public boolean onOptionsItemSelected(MenuItem item) { // Handle
 * action bar item clicks here. The action bar will // automatically handle
 * clicks on the Home/Up button, so long // as you specify a parent activity in
 * AndroidManifest.xml. int id = item.getItemId();
 * 
 * //noinspection SimplifiableIfStatement if (id == R.id.action_settings) {
 * return true; }
 * 
 * return super.onOptionsItemSelected(item); } }
 */