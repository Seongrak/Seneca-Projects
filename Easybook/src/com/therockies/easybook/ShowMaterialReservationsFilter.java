package com.therockies.easybook;

//Seongrak Choi
import java.io.IOException;
import java.sql.SQLException;
import java.util.List;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.annotation.WebFilter;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import ca.dmay.easybook.data.MaterialReservationDAOFactory;
import ca.senecacollege.prg556.limara.bean.AccountOwner;
import ca.senecacollege.prg556.limara.bean.Material;

import com.therockies.easybook.BadRequestException;

/**
 * Servlet Filter implementation class ShowMaterialReservationsFilter
 */

public class ShowMaterialReservationsFilter implements Filter {

    /**
     * Default constructor. 
     */
    public ShowMaterialReservationsFilter() {
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see Filter#destroy()
	 */
	public void destroy() {
		// TODO Auto-generated method stub
	}

	/**
	 * @see Filter#doFilter(ServletRequest, ServletResponse, FilterChain)
	 */
	public void doFilter(ServletRequest req, ServletResponse resp, FilterChain chain) throws IOException, ServletException {
		// TODO Auto-generated method stub
		// place your code here
		
		HttpServletRequest request = (HttpServletRequest)req;
		HttpServletResponse response = (HttpServletResponse)resp;
		HttpSession session = request.getSession();
		AccountOwner accountOwner = (AccountOwner)session.getAttribute("accountOwner");
		
		try
		{
			request.setAttribute("MaterialReservation",MaterialReservationDAOFactory.getMaterialReservationDAO().getMaterialReservations(accountOwner.getId()));
			
			if ("POST".equals(request.getMethod()) && request.getParameter("Cancel") != null)
			{
				String materialID = request.getParameter("materialID");
				if(null != MaterialReservationDAOFactory.getMaterialReservationDAO().getMaterialReservation(accountOwner.getId(), materialID))
				{
					MaterialReservationDAOFactory.getMaterialReservationDAO().cancelMaterialReservation(accountOwner.getId(), materialID);
					request.setAttribute("MaterialReservation",MaterialReservationDAOFactory.getMaterialReservationDAO().getMaterialReservations(accountOwner.getId()));
				}
				else
				{
					throw new BadRequestException("Material ID is not vaild.");
				}
			}
		}
		
		catch (SQLException sqle) 
		{
			throw new ServletException(sqle);
		} 
		// pass the request along the filter chain
		chain.doFilter(req, resp);
	}

	/**
	 * @see Filter#init(FilterConfig)
	 */
	public void init(FilterConfig fConfig) throws ServletException {
		// TODO Auto-generated method stub
	}

}
