package com.therockies.easybook;

import javax.annotation.Resource;
import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;
import javax.servlet.annotation.WebListener;
import javax.sql.DataSource;

import ca.dmay.easybook.data.DataSourceFactory;


/**
 * Application Lifecycle Listener implementation class LimaraContextListener
 *
 */
@WebListener
public class LimaraContextListener implements ServletContextListener {

	@Resource(name = "LimaraDB")
	private DataSource _ds;
	
    /**
     * Default constructor. 
     */
    public LimaraContextListener() {
        // TODO Auto-generated constructor stub
    }

	/**
     * @see ServletContextListener#contextInitialized(ServletContextEvent)
     */
    public void contextInitialized(ServletContextEvent context) {
        // TODO Auto-generated method stub
    	DataSourceFactory.setDataSource(_ds);
    }

	/**
     * @see ServletContextListener#contextDestroyed(ServletContextEvent)
     */
    public void contextDestroyed(ServletContextEvent context) {
        // TODO Auto-generated method stub
    	DataSourceFactory.setDataSource(null);
    }
	
}
