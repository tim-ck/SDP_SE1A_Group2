If the error message simuilar to:
"'sdpEntities' does not contain a definition for 'orders' and no accessible extension method 'orders' accepting a first argument of type 'sdpEntities' could be found (are you missing a using directive or an assembly reference?)	SDP_SE1A_Group2	C:\Users\tim_ck\Documents\GitHub\SDP_SE1A_Group2\Customer\CartPage.cs	164	Active
" 
has show up, please remove all the "s" and "es" of the Table Name, vice versa.

For Example:
var id = from a in db.orders =>
var id = from a in db.order 