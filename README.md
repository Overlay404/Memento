try
            {
                BdConect.db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                List<string> mess = new List<string>();

                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        mess.Add("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }

                MessageBox.Show(string.Join("\n", mess));
            }
